const prompt = require("prompt-sync")();

function getRandomInt(max) {
    return Math.floor(Math.random() * max);
}

let i = 0;
const secretNumber = getRandomInt(100);
let guess = Number(prompt("Guess the number: "));
while(guess != secretNumber) {
    if(Number(guess) > Number(secretNumber))
        console.log("Your guess was wrong. Less. ");

    if(Number(guess) < Number(secretNumber))
        console.log("Your guess was wrong. Greater. ");

        guess = Number(prompt("Guess the number: "))

        i++;
}


console.log("Yay you won! The number was: " + secretNumber + ` It took ${i} times`);