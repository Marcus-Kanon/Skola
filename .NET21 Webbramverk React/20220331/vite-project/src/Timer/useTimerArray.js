import { useEffect, useState } from "react";

export const useTimerArray = (ta, setTa, ti, setTi) => {
    const [timerArray, setTimerArray] = useState([]);
	const [timerIndex, setTimerIndex] = useState(0);

    useEffect(() => {
        setTimerArray(ta);
        setTimerIndex(ti);
    }, [ta, ti]);

    return {timerArray: timerArray,
        setTimerArray: setTimerArray,
        timerIndex: timerIndex,
        setTimerIndex: setTimerIndex};
}
