const prompt = require("prompt-sync")();

let str = "";
let exit = false;
let add;

while(!exit) {
    add = prompt(str);
    str += add + " ";

    if(add == "" || add == ".") {
        exit = true;
    }
}

