import React from "react";
import logo from "./logo.svg";
import "./App.css";
import Header from "./Header/Header.jsx";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Footer from "./Footer";
import Start from "./Main/Start";
import Search from "./Main/Search/Search";
import Team from "./Main/Team";


function App() {
    return (
        //Lägg data här
        <>
            <Router>
                <Header/>
                <main>
                    <Routes>
                        <Route path="/Start" element={<Start />} />
                        <Route path="/Search" element={<Search />} />
                        <Route path="/Team" element={<Team />} />
                    </Routes>
                </main>
            </Router>
            <Footer />
        </>
    );
}

export default App;
