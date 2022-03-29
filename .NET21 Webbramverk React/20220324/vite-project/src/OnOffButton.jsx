import React from "react";
import { useState } from "react";

const OnOffButton = () => {
    const [isOn, setBool] = useState(true);
    
    return(
        <div>
            <h2>On/off button</h2>
            <button onClick={() =>{ setBool(!isOn);}}>{isOn ? "On!" : "Off"}</button>
        </div>
    )
}

export default OnOffButton;