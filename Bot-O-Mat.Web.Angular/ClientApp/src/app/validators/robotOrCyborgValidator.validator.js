"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var botTypes_enum_1 = require("../enums/botTypes.enum");
var isCyborg = function (botType) { return botType.value === botTypes_enum_1.BotTypeEnum.Cyborg.toString(); };
var isRobot = function (botType) { return botType.value === botTypes_enum_1.BotTypeEnum.Robot.toString(); };
exports.robotOrCyborgValidator = function (formGroup) {
    var botType = formGroup.get('botTypeSelect');
    var robotType = formGroup.get('robotTypeSelect');
    var cyborgGender = formGroup.get('cyborgGenderSelect');
    if (isRobot(botType) && robotType.value)
        return null;
    else if (isRobot(botType) && !robotType.value)
        return { invalidRobotType: true };
    else if (isCyborg(botType) && cyborgGender.value)
        return null;
    else
        return { invalidCyborgGender: true };
};
//# sourceMappingURL=robotOrCyborgValidator.validator.js.map