var lib = (function ($, axios) {
    window.location.hash = "";

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
        log: function (message) {
            if (this.environment.IsLocal) {
                console.dir(message);
                if (message.data) {
                    console.log(message.data, "response");
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
            preview: function (imageElement, fileElement) {
                return new Promise((res, rej) => {
                    var preview = document.querySelector(imageElement);
                    var file = document.querySelector(fileElement).files[0];
                    var reader = new FileReader();

                    reader.addEventListener("load", function () {
                        preview.src = reader.result;
                        res(reader.result);
                    }, false);

                    if (file) {
                        reader.readAsDataURL(file);
                    }
                });
            },
            random: function (imageElement) {
                //https://stackoverflow.com/a/20285053
                return new Promise(async function (res, rej) {
                    var preview;
                    if (imageElement) {
                        preview = document.querySelector(imageElement);
                    }
                    const toDataURL = url => fetch(url)
                        .then(response => response.blob())
                        .then(blob => new Promise((resolve, reject) => {
                            const reader = new FileReader();
                            reader.onloadend = () => {
                                preview.src = reader.result;
                                resolve(reader.result);
                            };
                            reader.onerror = reject;
                            reader.readAsDataURL(blob);
                        }));


                    res(toDataURL('https://picsum.photos/200/200/?random'));
                    //.then(dataUrl => {
                    //    console.log('RESULT:', dataUrl);
                    //});
                });
            }
        },
        html: {
            generateCard: function (container, cardObject, direction, isSingle) {
                var parentContainer = $('<div>').addClass('card').addClass(direction);
                var cardContainer = parentContainer.append($('<div>').addClass('card_container'));
                if (cardObject.imageData) {
                    cardContainer.append($('<img>').attr('src', cardObject.imageData).attr('height', 200).attr('width', 200).css('border-radius', '50%'));
                }
                cardContainer.append($('<h4>').append('<b>').attr('id', 'cardTaskName_' + cardObject.actorId).text(cardObject.name + " (still working)"));
                cardContainer.append($('<div>').attr('id', 'cardTaskList_' + cardObject.actorId)).addClass('card_container');

                generateTasksHtml(cardObject.errandIds, cardObject.actorId);

                function generateTasksHtml(tasks, actorId) {
                    //https://codeburst.io/javascript-async-await-with-foreach-b6ba62bbf404
                    const start = async () => {
                        await asyncForEach(tasks, async (task) => {
                            var result = await lib.controllers.errands.post({ actorId: actorId, errandType: task });
                            result = result.data;
                            var success = result.completedSuccessfully === true ? '<b style="color:green;">successfully</b> performed task: ' : '<b style="color: red;">utterly failed</b> task: ';
                            $(`#cardTaskList_${actorId}`).append($('<p>').html(`${cardObject.name} ${success} <b>${result.errand}<b>!`));
                            if (result.terminatedActorId) {
                                $(`#cardTaskList_${actorId}`).append($('<p>')).append($('<b>').css('color', 'red').text(`${cardObject.name} managed to destroy a unit (${result.terminatedActorName})!`));
                            }
                        });
                        $(`#cardTaskName_${actorId}`).text(cardObject.name);
                    };

                    start();

                    async function asyncForEach(array, callback) {
                        for (let index = 0; index < array.length; index++) {
                            await callback(array[index], index, array);
                        }
                    }
                }

                container.append(parentContainer);

                if (isSingle) {
                    $('.card').css('width', '80%').css('margin', 'auto').removeClass('cardLeft').removeClass('cardRight');
                } else {
                    $('.card').css('margin-left', '10px').css('margin-right', '10px').css('width', '45%');
                }
            }
        }
    };

    var controllers = {
        apiHost: "https://localhost:44308/api",
        actors: {
            robot: {
                get: async function (id) {
                    try {
                        var response = await axios.get(`${lib.controllers.apiHost}/robot/${id}`);
                        lib.helpers.log(response);
                        return response;
                    } catch (e) {
                        lib.helpers.log.error(e);
                        throw e;
                    }
                },
                post: async function (body) {
                    try {
                        var response = await axios.post(`${lib.controllers.apiHost}/robot`, body);
                        lib.helpers.log(response);
                        return response;
                    } catch (e) {
                        lib.helpers.log.error(e);
                        throw e;
                    }
                }
            },
            cyborg: {
                get: async function (id) {
                    try {
                        var response = await axios.get(`${lib.controllers.apiHost}/cyborg/${id}`);
                        lib.helpers.log(response);
                        return response;
                    } catch (e) {
                        lib.helpers.log.error(e);
                        throw e;
                    }
                },
                post: async function (body) {
                    try {
                        var response = await axios.post(`${lib.controllers.apiHost}/cyborg`, body);
                        lib.helpers.log(response);
                        return response;
                    } catch (e) {
                        lib.helpers.log.error(e);
                        throw e;
                    }
                }
            }
        },
        images: {
            get: async function (actorId) {
                try {
                    var response = await axios.get(`${lib.controllers.apiHost}/image/${actorId}`);
                    lib.helpers.log(response);
                    return response;
                } catch (e) {
                    lib.helpers.log.error(e);
                    throw e;
                }
            },
            post: async function (body) {
                try {
                    var response = await axios.post(`${lib.controllers.apiHost}/image`, body);
                    lib.helpers.log(response);
                    return response;
                } catch (e) {
                    lib.helpers.log.error(e);
                    throw e;
                }
            }
        },
        errands: {
            post: async function (body) {
                try {
                    var response = await axios.post(`${lib.controllers.apiHost}/errand`, body);
                    lib.helpers.log(response);
                    return response;
                } catch (e) {
                    lib.helpers.log.error(e);
                    throw e;
                }
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
                        lib.views.index.createActorModal.validate(async function (result) {
                            if (result) {
                                await lib.views.index.createActorModal.submit(
                                    lib.helpers.http.JsonStringifyForm($('#createActorModal')),
                                    $('#actorSelect').val().toLowerCase());
                            }
                        });
                    });
                    $('#actorSelect').change(function () {
                        $('.SubType').hide();
                        $(`#${$(this).val()}SubType`).show();
                    });
                    $('#actorPreviewFile').change(async function () {
                        await lib.helpers.images.preview('#actorPreview', '#actorPreviewFile');
                        $("#actorPreview").show();
                        $("#preview").hide();
                        $("#previewRemove").show();
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
                submit: async function (body, type) {
                    var response = await controllers.actors[type].post(body);
                    await lib.views.index.createActorModal.handleResponse(response);
                },
                handleResponse: async function (response) {
                    $('#actorId').val(response.data.id);
                    $('#actorType').val(response.data.actorType);

                    if ($('#actorPreviewFile').val()) {
                        response.data.ImageData = await lib.helpers.images.preview('#actorImageErrands', '#actorPreviewFile');
                        await lib.controllers.images.post({ ActorId: response.data.id, ImageData: response.data.ImageData.split(',')[1] });
                        $("#actorImageErrands").show();
                        lib.views.index.createActorErrandsModal.show(response);
                    } else {
                        response.data.ImageData = await lib.helpers.images.random('#actorImageErrands');
                        await lib.controllers.images.post({ ActorId: response.data.id, ImageData: response.data.ImageData.split(',')[1] });
                        $("#actorImageErrands").show();
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
                                lib.views.index.createActorErrandsModal.submit({
                                    actorId: $('#actorId').val(),
                                    userCreated: true,
                                    errandIds: Array.from($('#createActorErrandsModal input:checked')).map(element => element.value)
                                });
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
                    $('.card').remove();

                    lib.views.index.errandReport.show(actor);
                },
                show: function (actor) {
                    window.location.hash = 'open-modal-errands';
                }
            },
            errandReport: {
                show: async function (actor, index) {
                    var actorCard = {
                        actorId: actor.id,
                        errandIds: actor.errandIds,
                        name: actor.name,
                        imageData: actor.imageData
                    };
                    if (actor.userCreated) {
                        var response = await lib.controllers.actors[$('#actorType').val().toLowerCase()].get($('#actorId').val());
                        actorCard = response.data;
                        var image = await lib.controllers.images.get($('#actorId').val());
                        actorCard.imageData = "data:image/jpeg;base64," + image.data;
                        actorCard.errandIds = actor.errandIds;
                        actorCard.actorId = actor.actorId;
                    }

                    lib.helpers.html.generateCard($('#cardParentContainer'), actorCard, index % 2 === 0 ? "cardLeft" : "cardRight", actor.userCreated);
                    window.location.hash = 'open-modal-errands-report';
                }
            }
        },
        factory: {
            eventListeners: function () {
                $('#beginManufacturing').unbind().click(lib.views.factory.beginManufacturing);
            },
            actorTypes: function () {
                return ['robot', 'cyborg'];
            },
            beginManufacturing: function () {
                //TODO: does too much, separate
                $('.card').remove();
                var requests = [];

                setTimeout(function () {
                    $('#beginManufacturing').hide();
                    $('#factorySpinner').show();
                }, 300);
                //TODO: styling issue with cards if > 2 :(
                for (var i = 0; i < 2; i++) {
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

                Promise.all(requests).then(function (actors) {
                    var count = 1;
                    setTimeout(function () {
                        $('#beginManufacturing').show();
                        $('#factorySpinner').hide();
                    }, 3000);

                    actors.forEach(async function (actor, index, array) {
                        actor.json().then(async function(res) {
                            var tasks = [];
                            var numberOfTasksToRun = Math.floor(Math.random() * 6);
                            var taskOptions = $("#createActorErrandsModal > input");
                            numberOfTasksToRun = numberOfTasksToRun === 0 ? 1 : numberOfTasksToRun;

                            res.imageData = await lib.helpers.images.random('#actorImageErrands');
                            await lib.controllers.images.post({ ActorId: res.id, ImageData: res.imageData.split(',')[1] });

                            for (var i = 0; i < numberOfTasksToRun; i++) {
                                tasks.push(taskOptions[Math.floor(Math.random() * taskOptions.length) === 0 ? 1 : Math.floor(Math.random() * taskOptions.length)].name)
                            }
                            res.errandIds = tasks;

                            lib.views.index.errandReport.show(res, count++);
                        });
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