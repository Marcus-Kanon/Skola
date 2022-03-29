import React from 'react';
function Orderly(props) {

    const message = (n) => {
        switch(n) {
            case '1': return "1st";
            case '2': return "2nd";
            case '3': return "3rd";
            case '4': return "4th";
            case '5': return "5th";
            default: return n+"th";
        }
    }

    return ( 
        <div>{message(props.value)}</div>
     );
}

export default Orderly;