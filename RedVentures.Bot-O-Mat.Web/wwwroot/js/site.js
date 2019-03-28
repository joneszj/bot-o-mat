/*jshint esversion: 8 */
/* globals faker, signalR, $, axios */

//TODO: this lib can use some serious refactoring/testing tlc
//TODO: recfactor in services object to managed updates requests by the views object
//TODO: encapsulate lib features
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
                    indexed_array[n.name] = n.name;
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
                });
            }
        },
        html: {
            //TODO: this may be better split into a single and a many 
            //TODO: encapsulate into a service and correct the incomint param ooj props to be homogenous
            //TODO: extract html built components into a resources object
            generateCard: function (container, cardObject, direction, isSingle) {
                var parentContainer = $('<div>').addClass('card').addClass(direction);
                var cardContainer = parentContainer.append($('<div>').addClass('card_container'));
                if (cardObject.imageData) {
                    cardContainer.append($('<img>').attr('src', cardObject.imageData).attr('height', 200).attr('width', 200).css('border-radius', '50%'));
                } else if ($('#actorImage').val()) {
                    cardContainer.append($('<img>').attr('src', $('#actorImage').val()).attr('height', 200).attr('width', 200).css('border-radius', '50%'));
                }
                if (!cardObject.name) {
                    cardObject.name = $('#actorName').val();
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

    //TODO: controllers doesn't feel like the best term to describe an object that is essentially a service boundary provider
    //TODO: inject apiHost
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
            },
            actor: {
                get: async function (id) {
                    try {
                        var response = await axios.get(`${lib.controllers.apiHost}/actor/${id}`);
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

    //TODO: break index into a partials object
    //TODO: implement real time updates on the views
    var views = {
        index: {
            showBody: function () {
                //body is hidden by default to hide html transformations
                $('body').fadeIn();
            },
            createActorModal: {
                eventListeners: function () {
                    $("#CTASubmit").click(function (event) {
                        event.preventDefault();
                        lib.views.index.createActorModal.validate(async function (result) {
                            if (result) {
                                $('#userCreated').val(true);
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

                    $(document).keyup(function (e) {
                        //https://stackoverflow.com/questions/3369593/how-to-detect-escape-key-press-with-pure-js-or-jquery
                        if (e.key === "Escape") {
                            window.location.hash = "";
                        }
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
                                    id: $('#actorId').val(),
                                    userCreated: $('#userCreated').val() || false,
                                    errandIds: Array.from($('#createActorErrandsModal input:checked')).map(element => element.value),
                                    renderSingleCard: true
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
            showDetailModal: function () {
                $('a[href="#open-modal-detail"]').click(async function () {
                    //hide details, show spinner
                    var actor = await lib.controllers.actors.actor.get($(this).data("id"));
                    actor = actor.data;
                    $('#actorId').val(actor.id);
                    $('#actorType').val(actor.type);
                    if (actor.image) {
                        $('#actorImage').val("data:image/jpeg;base64," + actor.image);
                    }
                    $('#actorName').val(actor.name);
                    if (actor.image) {
                        $('#detail_image').attr('src', "data:image/jpeg;base64," + actor.image).attr('height', 200).attr('width', 200).css('border-radius', '50%').show();
                        $('#actorImageErrands').attr('src', "data:image/jpeg;base64," + actor.image).attr('height', 200).attr('width', 200).css('border-radius', '50%').show();
                        $('#detail_no_image').attr('src', actor.image).hide();
                    } else {
                        $('#detail_no_image').attr('src', actor.image).show();
                        $('#detail_image').hide();
                    }
                    $('#datail_name').html(`My name is ${actor.name}!`);
                    $('#datail_type').html(`I'm a ${actor.type}!`);

                    $('#detail_completed_tasks_div').show();
                    $('#detail_completed_tasks').html('');
                    if (!actor.completedErrands.length) {
                        $('#detail_completed_tasks_div').hide();
                    }
                    actor.completedErrands.forEach(function (v, i, a) {
                        $('#detail_completed_tasks').append(`<li>${v.errandTypeName} in ${v.timeToComplete} milliseconds!</li>`);
                    });

                    $('#detail_failed_tasks_div').show();
                    $('#detail_failed_tasks').html('');
                    if (!actor.failedErrands.length) {
                        $('#detail_failed_tasks_div').hide();
                    }
                    actor.failedErrands.forEach(function (v, i, a) {
                        $('#detail_failed_tasks').append(`<li>${v.errandTypeName} in ${v.timeToComplete} milliseconds!</li>`);
                    });
                    //load actor chat
                    $('#details_chat').show().html('');
                    if (!actor.active) {
                        $('#detail_failed_tasks').hide();
                    }
                    //show details, hide spinner
                });
                $('#assignNewTasks').click(function () {
                    $('#userCreated').val(false);
                    lib.views.index.createActorErrandsModal.show();
                });
            },
            errandReport: {
                show: async function (actor, index) {
                    var actorCard = {
                        actorId: actor.id,
                        errandIds: actor.errandIds,
                        name: actor.name,
                        imageData: actor.imageData
                    };
                    if (actor.userCreated === 'true' || actor.userCreated === true) {
                        var response = await lib.controllers.actors[$('#actorType').val().toLowerCase()].get($('#actorId').val());
                        actorCard = response.data;
                        var image = await lib.controllers.images.get($('#actorId').val());
                        actorCard.imageData = "data:image/jpeg;base64," + image.data;
                        actorCard.errandIds = actor.errandIds;
                        actorCard.actorId = actor.id;
                    }

                    lib.helpers.html.generateCard($('#cardParentContainer'), actorCard, index % 2 === 0 ? "cardLeft" : "cardRight", actor.renderSingleCard || false);
                    window.location.hash = 'open-modal-errands-report';
                }
            }
        },
        factory: {
            eventListeners: function () {
                $('#beginManufacturing').unbind().click(lib.views.factory.beginManufacturing);
                $('#beginUberManufacturing').unbind().click(lib.views.factory.beginUberManufacturing);
            },
            actorTypes: function () {
                return ['robot', 'cyborg'];
            },
            beginUberManufacturing: function () {
                var response = prompt("WARNING! Uber Manufacturing allows you to created any number of units! The report modal will likely render buggy. To continue (at your own risk... turn back now), type a number for the unit creation count below and press Ok.");
                if (response) {
                    //interesting way to convert string to num https://stackoverflow.com/a/175787
                    if (Number.isInteger(parseInt(response))) {
                        lib.views.factory.beginManufacturing(Math.abs(response));
                    }

                }
            },
            beginManufacturing: function (count) {
                //TODO: does too much, separate
                $('.card').remove();
                var requests = [];

                setTimeout(function () {
                    $('#beginManufacturing').hide();
                    $('#beginUberManufacturing').hide();
                    $('#factorySpinner').show();
                }, 300);
                //TODO: styling issue with cards if > 2 :(
                count = !isNaN(count) ? count : 2;
                for (var i = 0; i < count; i++) {
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
                        $('#beginUberManufacturing').show();
                        $('#factorySpinner').hide();
                    }, 3000);

                    actors.forEach(async function (actor, index, array) {
                        actor.json().then(async function (res) {
                            var tasks = [];
                            var numberOfTasksToRun = Math.floor(Math.random() * 6);
                            var taskOptions = $("#createActorErrandsModal > input");
                            numberOfTasksToRun = numberOfTasksToRun === 0 ? 1 : numberOfTasksToRun;

                            res.imageData = await lib.helpers.images.random('#actorImageErrands');
                            await lib.controllers.images.post({ ActorId: res.id, ImageData: res.imageData.split(',')[1] });

                            for (var i = 0; i < numberOfTasksToRun; i++) {
                                tasks.push(taskOptions[Math.floor(Math.random() * taskOptions.length) === 0 ? 1 : Math.floor(Math.random() * taskOptions.length)].name);
                            }
                            res.errandIds = tasks;

                            lib.views.index.errandReport.show(res, count++);
                        });
                    });
                });
            }
        }
    };

    var services = {
        signalrR: {
            Init: (function () {
                document.addEventListener('DOMContentLoaded', function () {
                    var connection = new signalR.HubConnectionBuilder()
                        .withUrl('https://localhost:44308/notification')
                        .build();

                    connection.on('Notify', function (notification) {
                        lib.services.notification(notification.message, notification.severityLevel.toLowerCase());
                    });

                    connection.start()
                        .then(function () {
                            console.log('connection started');
                        })
                        .catch(error => {
                            console.error(error.message);
                        });
                });
            })()
        },
        notification: function (message, type) {
            $.notify(message, { className: type, globalPosition: 'bottom right' });
        }
    };

    return {
        controllers: controllers,
        helpers: helpers,
        views: views,
        services: services
    };
})($, axios);