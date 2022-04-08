function isInputNotEmpty(input) {
    return input != "";
}

function isInputOnlyCharacters(input) {
    return RegExp(/^[a-z]+$/).test(input);
}

function isInputOnlyNumbers(input) {
    return RegExp(/^[0-9]+$/).test(input);
}

export { isInputNotEmpty, isInputOnlyCharacters, isInputOnlyNumbers };
