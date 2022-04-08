import React from 'react';
import logo from './logo.svg'
import './App.css'
import Header from './Header/Header.jsx'
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';

function App() {

	return (
	  <div>

	  
	  <Router>
	  <Header></Header>
		  <Routes>
			  <Route path="/Start" element={<div>Home</div>} />
			  <Route path="/Search" element={<div>About</div>} />
			  <Route path="/Team" element={<div>Contact</div>} />
		  </Routes>
	  </Router>
	  </div>
  )
}

export default App
