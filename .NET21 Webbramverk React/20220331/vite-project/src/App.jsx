import { useState, useEffect } from "react";
import logo from "./logo.svg";
import "./App.css";
import Timer from "./Timer/Timer";

const useTimers = (defaultTimerArray, defaultTimerIndex) => {
	const [timerArray, setTimerArray] = useState(defaultTimerArray);
	const [timerIndex, setTimerIndex] = useState(defaultTimerIndex);

	const getIndex = () => {
		return timerIndex;
	};

	function setIndex (index) {
		setTimerIndex(index);
	};

	const getTimers = () => {
		return timerArray;
	}

	function setTimers (timers){
		setTimerArray(timers);
	}
	return {timerIndex: getIndex, setTimerIndex: setIndex, timerArray: getTimers, setTimerArray: setTimers};


}

const addTimer = (timerArray, setTimerArray, timerIndex, setTimerIndex) => {
	setTimerIndex(timerIndex()+1);
	console.log(timerIndex());
	const element = <Timer key={timerIndex()} eId={timerIndex()} timerArray={timerArray} setTimerArray={setTimerArray} timerIndex={timerIndex} setTimerIndex={setTimerIndex} deleteTimer={deleteTimer} />
	setTimerArray([...timerArray(), element]);
};

const deleteTimer = (eId, timerArray, setTimerArray, timerIndex) => {
	setTimerArray(
		timerArray.map(element => {
			if(element !== timer){return element}
		})
	);
};

function App() {

	const { timerIndex, setTimerIndex, timerArray, setTimerArray} = useTimers([], 0);
	
	// useEffect(() => {
	// 	addTimer(timerArray, setTimerArray, timerIndex, setTimerIndex);
	// }, []);

	// const makeTimer = () => {
	// 	return (
	// 		<Timer key={timerArray.length} deleteTimer={deleteTimer} />
	// 	)
	// }
    return (
        <div className="App">
			{timerArray()}
			<br />
			<button onClick={() => addTimer(timerArray, setTimerArray, timerIndex, setTimerIndex)}>Add Timer</button>
        </div>
    );
}

export default App;
