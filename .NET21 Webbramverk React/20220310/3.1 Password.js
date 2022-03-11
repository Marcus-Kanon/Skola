const prompt = require("prompt-sync")();

let passChecker = function(password) {
    if(password == "123")
        return true;
}

let password = prompt("Password: ");

while(!passChecker(password))
{
    password = prompt("Wrong password. Try again: ");
}

console.log("You are logged in!");
