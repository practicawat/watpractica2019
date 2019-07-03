"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var CarService = /** @class */ (function () {
    function CarService(http) {
        this.http = http;
        this.profileUrl = "api/Employees/";
    }
    CarService.prototype.getAllCars = function () {
        return this.http.get(this.profileUrl);
    };
    return CarService;
}());
exports.CarService = CarService;
//# sourceMappingURL=cars.service.js.map