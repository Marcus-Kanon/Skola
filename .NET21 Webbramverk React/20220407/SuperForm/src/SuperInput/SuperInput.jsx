import React from "react";
import { useState, useEffect, useContext } from "react";
import "./SuperInput.css";

function SuperInput(props) {
    const [input, setInput] = useState(0);
    const [inputClass, setInputClass] = useState("");

    useEffect(() => {
        props.addToRegister(props.nodeId);
    }, []);

    useEffect(() => {
        if (inputValidator(props.validation, input)) {
            setInputClass("inputValid");
        } else {
            setInputClass("inputInvalid");
        }
    }, [input]);

    function inputValidator(validators, input) {
        for (const func in validators) {
            if (!validators[func](input)) {
                return false;
            }
        }

        return true;
    }

    props.handler(input, this);

    return (
        <div>
            <label>{props.label}</label>
            <input
                className={inputClass}
                type="text"
                onChange={(event) => setInput(event.target.value)}
            />
        </div>
    );
}

export default SuperInput;
