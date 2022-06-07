import React from "react";

function Fancy(props) {
    const styles = {color: props.color};
    return (
        <span style={styles}>{props.children}</span>
    );
}

export default Fancy;