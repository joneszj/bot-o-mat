"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var botTypes_enum_1 = require("../enums/botTypes.enum");
var botEnum = botTypes_enum_1.BotTypeEnum;
var isCyborg = function (botType) { return Number(botType.value) === botEnum.Cyborg; };
var isRobot = function (botType) { return Number(botType.value) === botEnum.Robot; };
exports.robotOrCyborgValidator = function (formGroup) {
    var botType = formGroup.get('botTypeSelect');
    var robotType = formGroup.get('robotTypeSelect');
    var cyborgGender = formGroup.get('cyborgGenderSelect');
    if (isRobot(botType) && robotType.value !== -1)
        return null;
    else if (isRobot(botType) && Number(robotType.value) === -1)
        return { invalidRobotType: true };
    else if (isCyborg(botType) && Number(cyborgGender.value) !== -1)
        return null;
    else
        return { invalidCyborgGender: true };
};
//# sourceMappingURL=robotOrCyborgValidator.validator.js.map