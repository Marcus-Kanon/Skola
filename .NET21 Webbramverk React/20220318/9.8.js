let Words = [];
let AtWord = 0;
let AtCharacter = 0;
let Timer = 0;

Timer = Date.now();

function inputReceiverKeyDown(e) {
    if(e.key == Words[AtWord][AtCharacter]) {
        console.log("Rätt");
        AtCharacter++;
        if(AtCharacter >= Words[AtWord].length) {
            let timeNow = Date.now();
            let timePassed = timeNow - Timer;
            console.log(timePassed);
            let charPerSec = (Words[AtWord].length / (timePassed / 1000)).toFixed(2);
            document.querySelector("#Time").innerHTML = charPerSec + " characters per second";

            AtWord++;

            AtCharacter=0;
            Timer = Date.now();

            console.log("Nästa");
        }
    }

    let tempWord = "";

    for (let i = 0; i < Words[AtWord].length; i++) {

        if(i < AtCharacter) {
            tempWord += "<span style='color: #00ff00'>" + Words[AtWord][i] + "</span>";
        }
        else{
            tempWord += Words[AtWord][i];
        }

    }


    document.querySelector("#Word").innerHTML = tempWord;
}

function randomInt(max) {
    return Math.floor(Math.random()*max);
}

function ReadFile() {

    let File = "engmix.txt";
    let Req = new XMLHttpRequest();

    Req.open("GET", File, false);

    Req.onreadystatechange = () =>
    {
        if(Req.readyState === 4) {
            if(Req.status === 200 || File.status == 0) {
                let tempWords = Req.responseText.split("\n");

                selectWords(tempWords, 10);
            }
        }
    }
    Req.send(null);

}

function selectWords(wordArray, numberOfWords) {
    for (let i = 0; i < numberOfWords; i++) {
        Words.push(wordArray[randomInt(wordArray.length)]);  
    }
}

ReadFile();

addEventListener("keydown", e => inputReceiverKeyDown(e));