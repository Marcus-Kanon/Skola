import React from "react";
import { useState, useEffect, useContext } from "react";
import "./EditableText.css";

function SuperInput(props) {
    const [input, setInput] = useState(props.label);
    const [inputClass, setInputClass] = useState("");

    useEffect(() => {
        setValidationClass();
    }, [input]);

    function setValidationClass() {
        if (inputValidator(props.validation, input)) {
            setInputClass("inputValid");
        } else {
            setInputClass("inputInvalid");
        }
    }

    function inputValidator(validators, input) {
        for (const func in validators) {
            if (!validators[func](input)) {
                return false;
            }
        }

        return true;
    }

    return (
        <div>
            <input
                value={input}
                className={inputClass}
                type="text"
                onChange={(event) => setInput(event.target.value)}
                onBlur={() => inputValidator(props.validation, input) ? props.handler(input, props.id) : null}
            />
        </div>
    );
}

export default SuperInput;
