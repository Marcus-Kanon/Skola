const prompt = require("prompt-sync")();

function NumberCheckerMessage (number) {
    if(this.number > 100) {
        return "greater than 100";
    }
    else if(this.number == 100) {
        return "equal to 100";
    }
    else {
        return "below 100";
    }
}

let number = prompt("Give me a number:");

console.log(number + " is " + NumberCheckerMessage(number));
