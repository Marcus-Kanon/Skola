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

    const [data, setData] = useState([]);
    const [team, setTeam] = useState([]);
    const [cachedDetails, setCachedDetails] = useState([]);

    useEffect(() => {
        async function something() {
            let incoming = await populatePokemonList();
            setData(incoming);

        }
        something();
        // setSearch(data.results.map(pokemon => (
        //     <PokemonCard key={pokemon.url} pokemon={pokemon}>
        //         <a onClick={() => {addTeamMember(pokemon)}}>Add to team</a>
        //     </PokemonCard>
        // )));
    }, []);

    return (
        <>
            <Router>
                <Header/>
                <main>
                    <Routes>
                        <Route path="/Start" element={<Start />} />
                        <Route path="/Search" element={<Search dataState={{data, set: setData}} teamState={{team, set: setTeam}} cachedDetailsState={{cachedDetails, set: setCachedDetails}} />} />
                        <Route path="/Team" element={<Team teamState={{team, set: setTeam}} cachedDetailsState={{cachedDetails, set: setCachedDetails}}  />} />
                    </Routes>
                </main>
            </Router>
            <Footer />
        </>
    );
}

export default App;
