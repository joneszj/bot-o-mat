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
                if (callback) {
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
            },
            many: function (requests) {
                return new Promise(function (res, rej) {

                });
            }
        },
        images: {
            post: function (body, callback) {
                axios.post(`${lib.controllers.apiHost}/images`, body)
                    .then(function (response) { lib.helpers.log(response, callback); })
                    .catch(lib.helpers.log.error);
            }
        }
    };

    var views = {
        index: {
            createActorModal: {
                eventListeners: function () {
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

                    if (callback) {
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
                                lib.controllers.images.post({ ActorId: response.data.id, ImageData: data.split(',')[1] }, lib.views.index.createActorErrandsModal.show);
                            });
                        });
                    } else {
                        lib.views.index.createActorErrandsModal.show(response);
                    }
                }
            },
            createActorErrandsModal: {
                show: function (actor) {
                    window.location.hash = 'open-modal-errands';
                }
            }
        },
        factory: {
            actorTypes: function () {
                return ['robot', 'cyborg'];
            },
            errands: function () {
                return [];
            },
            beginManufacturing: function () {
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