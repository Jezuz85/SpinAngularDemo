define(["require", "exports"], function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Lazy = void 0;
    class Lazy {
        constructor(from = "") {
            this.instance = null;
            this.from = from;
        }
        get value() {
            if (this.instance == null) {
                this.instance = new this.initializer();
            }
            return this.instance;
        }
    }
    exports.Lazy = Lazy;
});
