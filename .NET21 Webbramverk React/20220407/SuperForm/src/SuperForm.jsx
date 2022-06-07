import React from 'react';
import { useState } from "react";
import { useContext } from "react";
import logo from "./logo.svg";
import SuperInput from "./SuperInput/SuperInput";
import {isInputNotEmpty, isInputOnlyCharacters, isInputOnlyNumbers} from './SuperInput/validInputCheckers.js';
import { addToRegister, nodes } from './RegisterModule.js';

function inputHandler(input, nodeId) {
	//console.log(input);
}

function SuperForm() {
    return (
		<div>
			<SuperInput nodeId="1" label="Skriv text: " validation={{isInputNotEmpty, isInputOnlyCharacters}} addToRegister={addToRegister} handler={inputHandler} />
			<SuperInput nodeId="2" label="Skriv nummer: " validation={{isInputNotEmpty, isInputOnlyNumbers}} addToRegister={addToRegister} handler={inputHandler} />
		</div>
	);
}

export default SuperForm;
