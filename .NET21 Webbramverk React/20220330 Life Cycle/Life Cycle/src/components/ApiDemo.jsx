import React from 'react';
import { useEffect } from 'react';
import { useState } from 'react';
import './ApiDemo.css';

function ApiDemo() {
    const [data, setData] = useState({});
    const [BtnLoadDataClassName, setBtnLoadDataClassName] = useState("BtnLoadData");

    useEffect(() => {
        fetchData();
    }, []);

    const fetchData = () => {
        fetch("https://api.chucknorris.io/jokes/random")
            .then((response) => response.json())
            .then((json) => {
                setData(json);
                setBtnLoadDataClassName("BtnLoadData");
                console.log(data);
            });
    };

    const onBtnLoadDataClick = () => {
        setBtnLoadDataClassName("BtnLoadDataDisabled");
        fetchData();
    };

    return (
        <div>
            <h1>ApiDemo</h1>
            <p>{JSON.stringify(data)}</p>
            <button className={BtnLoadDataClassName} onClick={onBtnLoadDataClick}>Load data!</button>
        </div>
    );
}

export default ApiDemo;