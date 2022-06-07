const prompt = require("prompt-sync")();

function MonthToNumber(month) {
    switch(month)
    {
        case "January": return 1;
        case "February": return 2;
        case "Mars": return 3;
        case "April": return 4;
        case "May": return 5;
        case "June": return 6;
        case "July": return 7;
        case "August": return 8;
        case "September": return 9;
        case "October": return 10;
        case "November": return 11;
        case "December": return 12;
        default: return "Error";
    }
}

let month = prompt("What month? ");

let monthNumber = MonthToNumber(month);

console.log("Month number:", monthNumber);