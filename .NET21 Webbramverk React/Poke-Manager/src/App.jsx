import React from "react";
import {useState, useEffect} from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import { populatePokemonList } from "./Main/Search/PokeDataFetcher";
import logo from "./logo.svg";
import "./App.css";
import Header from "./Header/Header.jsx";
import Footer from "./Footer";
import Start from "./Main/Start";
import Search from "./Main/Search/Search";
import Team from "./Main/Team";


function App() {

    const [data, setData] = useState(null);
    const [team, setTeam] = useState([]);
    const [cachedDetails, setCachedDetails] = useState(null);

    useEffect(() => {

        async function getData() {
            await populatePokemonList().then(data => {
                setData(data);
            });

        }
        getData();
    }, []);

    return (
        <>
        {data !== null ? (
            <Router>
                <Header/>
                <main>
                    <Routes>
                        <Route path="/Start" element={<Start />} />
                        <Route path="/Search" element={<Search dataState={{data, set: setData}} setData={setData} teamState={{team, set: setTeam}} cachedDetailsState={{cachedDetails, set: setCachedDetails}} />} />
                        <Route path="/Team" element={<Team teamState={{team, set: setTeam}} cachedDetailsState={{cachedDetails, set: setCachedDetails}}  />} />
                    </Routes>
                </main>
            </Router>
        ) : (
            <div>Loading...</div>
        )}

            <Footer />
        </>
    );
}

export default App;
