require('./tasks/spin-sys/sign.js')()
path = require('path')
var conf = require("./appsettings.json")
if (!conf.enviroment)
    conf.enviroment = "dev";

console.log();
console.log("== > YOU ARE CONTECT TO ENVIROMENT " + conf.Enviroment);
console.log();

requireDir = require('require-dir');
var dir = requireDir('./tasks',
    {
        recurse: true,
        extensions: ['.js', '.json'],
        filter: function (fullPath) {
            var isFilter = false;
            isFilter = fullPath.includes(path.sep + conf.Enviroment + path.sep) ||
                fullPath.endsWith("spin-sys") ||
                fullPath.endsWith("spin-sys" + path.sep + conf.Enviroment) ||
                fullPath.endsWith(path.sep + conf.Enviroment);

            return isFilter;
        }
});