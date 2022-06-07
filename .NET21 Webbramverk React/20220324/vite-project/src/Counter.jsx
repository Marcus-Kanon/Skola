import React from "react";
import { useState } from "react";

function Counter() {
    const [counter, setCounter] = useState(0);

    return(
        <div>
            <button onClick={() => setCounter(counter + 1)}>Counter! {counter}</button><br></br>
            <button onClick={() => setCounter(counter - 1)}>Minska!</button>
        </div>
    );
}

export default Counter;