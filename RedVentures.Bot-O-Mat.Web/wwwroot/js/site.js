var lib = (function ($, axios) {
    if (!$) {
        alert("jQuery not imported");
    }
    if (!axios) {
        alert("axios not imported");
    }

    var helpers = {
        environment: {
            IsLocal: window.location.href.indexOf('localhost') > -1
        },
        log: function (message, callback) {
            if (this.environment.IsLocal) {
                console.dir(message);
                if (message.data) {
                    console.log(message.data, "response");
                }
                if (typeof callback === "function") {
                    callback(message);
                }
            }
        },
        error: function (message) {
            console.error(message);
        },
        http: {
            JsonStringifyForm: function (form) {
                var unindexed_array = form.serializeArray();
                var indexed_array = {};

                $.map(unindexed_array, function (n, i) {
                    indexed_array[n['name']] = n['value'];
                });

                return indexed_array;
            }
        },
        query: (function getParameterByName() {
            var vars = [], hash;
            var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
            for (var i = 0; i < hashes.length; i++) {
                hash = hashes[i].split('=');
                vars.push(hash[0]);
                vars[hash[0]] = hash[1];
            }
            return vars;
        })(),
        images: {
            preview: function (imageElement, fileElement, callback) {
                var preview = document.querySelector(imageElement);
                var file = document.querySelector(fileElement).files[0];
                var reader = new FileReader();

                reader.addEventListener("load", function () {
                    preview.src = reader.result;
                    callback(reader.result);
                }, false);

                if (file) {
                    reader.readAsDataURL(file);
                }
            }
        }
    };

    var controllers = {
        apiHost: "https://localhost:44308/api",
        actors: {
            robot: {
                post: function (body, callback) {
                    axios.post(`${lib.controllers.apiHost}/robot`, body)
                        .then(function (response) { lib.helpers.log(response, callback); })
                        .catch(lib.helpers.log.error);
                }
            },
            cyborg: {
                post: function (body, callback) {
                    axios.post(`${lib.controllers.apiHost}/cyborg`, body)
                        .then(function (response) { lib.helpers.log(response, callback); })
                        .catch(lib.helpers.log.error);
                }
            }
        },
        images: {
            post: function (body, callback) {
                axios.post(`${lib.controllers.apiHost}/image`, body)
                    .then(function (response) { lib.helpers.log(response, callback); })
                    .catch(lib.helpers.log.error);
            }
        },
        errands: {
            post: function (body, callback) {
                axios.post(`${lib.controllers.apiHost}/errand`, body)
                    .then(function (response) { lib.helpers.log(response, callback); })
                    .catch(lib.helpers.log.error);
            }
        }
    };

    //TODO: build services abstractions to reduce work done in views
    var views = {
        index: {
            createActorModal: {
                eventListeners: function () {
                    $("#CTASubmit").click(function (event) {
                        event.preventDefault();
                        lib.views.index.createActorModal.validate(function (result) {
                            if (result) {
                                lib.views.index.createActorModal.submit(
                                    lib.helpers.http.JsonStringifyForm($('#createActorModal')),
                                    $('#actorSelect').val().toLowerCase(),
                                    lib.views.index.createActorModal.handleResponse);
                            }
                        });
                    });
                    $('#actorSelect').change(function () {
                        $('.SubType').hide();
                        $(`#${$(this).val()}SubType`).show();
                    });
                    $('#actorPreviewFile').change(function () {
                        lib.helpers.images.preview('#actorPreview', '#actorPreviewFile', function () {
                            $("#actorPreview").show();
                            $("#preview").hide();
                            $("#previewRemove").show();
                        });
                    });
                    $("#previewRemove").click(function () {
                        $("#preview").show();
                        $("#previewRemove").hide();
                        $("#actorPreview")[0].src = "";
                        $("#actorPreview").hide();
                    });
                },
                validate: function (callback) {
                    var isValid = true;
                    $("#createActorModalFormValidationSummary").hide();
                    $("#createActorModalFormValidationSummary ul").html("");

                    $('#createActorModal input:visible(), select:visible()').each(function (i, e) {
                        if (!$(this).val()) {
                            $("#createActorModalFormValidationSummary ul").append(`<li>${$(this).prev().text()} is Required</li>`);
                            ShowNotValidMessage();
                        }
                    });

                    if (typeof callback === "function") {
                        callback(isValid);
                    }

                    function ShowNotValidMessage() {
                        $("#createActorModalFormValidationSummary").show();
                        isValid = false;
                    }
                },
                enable_progressive_form_fill: function (form) {
                    $("input:visible(), select:visible()", form).unbind()
                        .blur(lib.views.index.createActorModal.validate)
                        .change(lib.views.index.createActorModal.validate)
                        .keyup(lib.views.index.createActorModal.validate);
                },
                submit: function (body, type) {
                    controllers.actors[type].post(body, function (response) {
                        lib.views.index.createActorModal.handleResponse(response);
                    });
                },
                handleResponse: function (response) {
                    if ($('#actorPreviewFile').val()) {
                        lib.helpers.images.preview('#actorPreview', '#actorPreviewFile', function (data) {
                            lib.helpers.images.preview('#actorImageErrands', '#actorPreviewFile', function (data) {
                                $("#actorImageErrands").show();
                                $('#robotId').val(response.data.id);
                                lib.controllers.images.post({ ActorId: response.data.id, ImageData: data.split(',')[1] }, lib.views.index.createActorErrandsModal.show);
                            });
                        });
                    } else {
                        lib.views.index.createActorErrandsModal.show(response);
                    }
                }
            },
            createActorErrandsModal: {
                eventListeners: function () {
                    $("#CTAErrandSubmit").click(function (event) {
                        event.preventDefault();
                        lib.views.index.createActorErrandsModal.validate(function (result) {
                            if (result) {
                                lib.views.index.createActorErrandsModal.submit([{
                                    actorId: $('#robotId').val(),
                                    errandIds: []
                                }]);
                            }
                        });
                    });
                    $('input', $('#createActorErrandsModal')).click(lib.views.index.createActorErrandsModal.validate);
                },
                validate: function (callback) {
                    var isValid = true;
                    $("#createActorErrandsModalFormValidationSummary").hide();
                    $("#createActorErrandsModalFormValidationSummary ul").html("");

                    isValid = $("input:checked", $('#createActorErrandsModal')).length > 0;

                    if (!isValid) {
                        $("#createActorErrandsModalFormValidationSummary ul").append(`<li>At Least 1 Errand is Required</li>`);
                        ShowNotValidMessage();
                    }

                    if (typeof callback === "function") {
                        callback(isValid);
                    }

                    function ShowNotValidMessage() {
                        $("#createActorErrandsModalFormValidationSummary").show();
                        isValid = false;
                    }
                },
                submit: function (actor) {
                    lib.views.index.errandReport.show(actor);
                },
                show: function (actor) {
                    window.location.hash = 'open-modal-errands';
                }
            },
            errandReport: {
                show: function (actors) {
                    if (!Array.isArray(actors)) { return lib.helpers.error('must pass an array of actors'); }
                    //render each actor
                    window.location.hash = 'open-modal-errands-report';
                    //perform actor errands concurrently per actor and render updates
                }
            }
        },
        factory: {
            actorTypes: function () {
                return ['robot', 'cyborg'];
            },
            beginManufacturing: function () {
                //TODO: does too much, separate
                var requests = [];

                setTimeout(function () {
                    $('#beginManufacturing').hide();
                    $('#factorySpinner').show();
                }, 300);
                var unitsToBuild = Math.floor(Math.random() * 21);
                var numberOfTasksToRun = Math.floor(Math.random() * 11);
                for (var i = 0; i < unitsToBuild; i++) {
                    var unitTypeToBuild = Math.floor(Math.random() * 2);

                    var genderOptions = $("#genderSelect > option");
                    var randomGender = genderOptions[Math.floor(Math.random() * genderOptions.length) === 0 ? 1 : Math.floor(Math.random() * genderOptions.length)];
                    var robotTypeOptions = $("#robotTypeSelect > option");
                    var randomRobotType = robotTypeOptions[Math.floor(Math.random() * robotTypeOptions.length) === 0 ? 1 : Math.floor(Math.random() * robotTypeOptions.length)];

                    var body = {
                        name: faker.name.findName(),
                        gender: randomGender.value === "" ? 1 : randomGender.value,
                        type: randomRobotType.value === "" ? 1 : randomRobotType.value
                    };

                    requests.push(fetch(lib.controllers.apiHost + '/' + lib.views.factory.actorTypes()[unitTypeToBuild], {
                        method: 'POST',
                        body: JSON.stringify(body),
                        headers: {
                            'Content-Type': 'application/json'
                        }
                    }));
                }

                Promise.all(requests).then(function (data) {
                    $('#beginManufacturing').show();
                    $('#factorySpinner').hide();
                    data.forEach(function (value, index, array) {
                        //TODO: errands - numberOfTasksToRun
                        value.json().then(res => res).then(response => console.log('Success:', JSON.stringify(response)));
                    });
                });
            }
        }
    };

    return {
        controllers: controllers,
        helpers: helpers,
        views: views
    };
})($, axios);