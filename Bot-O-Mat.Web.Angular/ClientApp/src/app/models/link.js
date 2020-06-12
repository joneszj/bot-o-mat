"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Link = /** @class */ (function () {
    function Link() {
    }
    // TypeGaurd: https://www.typescriptlang.org/docs/handbook/advanced-types.html#type-guards-and-differentiating-types
    // I added this because when reading properties of a class (ex apiService w/ Object.values) I may want to restrict/filter on this type
    // A typegaurd is the accepted means of doing so as typeof and instance of are problematic
    Link.isLink = function (link) { return link.URL !== undefined && link.Label !== undefined; };
    return Link;
}());
exports.Link = Link;
//# sourceMappingURL=link.js.map