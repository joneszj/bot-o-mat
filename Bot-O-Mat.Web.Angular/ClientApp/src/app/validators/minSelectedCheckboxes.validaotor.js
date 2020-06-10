"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
function minSelectedCheckboxes(min) {
    if (min === void 0) { min = 1; }
    var minSelectedCheckboxes = function (formArray) {
        var totalSelected = formArray.controls
            .map(function (control) { return control.value; })
            .reduce(function (prev, next) { return next ? prev + next : prev; }, 0);
        return totalSelected >= min ? null : { invalidMinimum: true };
    };
    return minSelectedCheckboxes;
}
exports.minSelectedCheckboxes = minSelectedCheckboxes;
//# sourceMappingURL=minSelectedCheckboxes.validaotor.js.map