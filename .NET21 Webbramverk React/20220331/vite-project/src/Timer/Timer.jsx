import React from 'react';
import { useState, useEffect } from 'react';
import "./Timer.css";


function Timer(props) {
    const [count, setCount] = useState(0);
    const [seconds, setSeconds] = useState(0);
    const [minutes, setMinutes] = useState(0);
    const [hours, setHours] = useState(0);
    const [isOn, setIsOn] = useState(0);

    //Every tick
    useEffect(() => {
        if(isOn) {
            setTimeout(() => {
                tick();
            }, 100)
        }

        return () => {
            //stop();
        }
    })




    const tick = () => {
        setCount(count + 1);

        if(count % 10 == 0)
            onSecondPassed();

        if(count % (10 * 60) == 0 && count!=0)
            onMinutePassed();

        if(count % (10 * 60 * 60) == 0 && count!=0)
            onHourPassed();
    };

    const reset = () => {
        setCount(0);
    }

    const start = () => {
        setIsOn(true);
    }

    const stop = () => {
        setIsOn(false);
    }

    const onSecondPassed = () => {
        setSeconds(seconds + 1);
    }

    const onMinutePassed = () => {
        setMinutes(minutes + 1);
    }

    const onHourPassed = () => {
        setHours(hours + 1);
    }

    return ( 
        <div className='timer'>
            <div onClick={() => props.deleteTimer(this, props.timerArray, props.setTimerArray, props.timerIndex)} className='btnDelete'>X</div>
            <h1>Timer</h1>
            <button className='btnStart' onClick={start}>Start</button>
            <button className='btnStop' onClick={stop}>Stop</button>
            <div className='count'>
                Seconds: {seconds}<br />
                Minutes: {minutes}<br />
                Hours: {hours}
            </div>
        </div>
     );
}

export default Timer;