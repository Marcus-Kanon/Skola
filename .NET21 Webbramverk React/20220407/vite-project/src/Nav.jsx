//Make a nav-bar
import React from 'react';
import { useState, useEffect, useContext } from 'react';
import { BrowserRouter as Router, Route, NavLink } from 'react-router-dom';

function Nav() {
    return ( 
        <div>
            
            <NavLink to="">Home</NavLink>
            <NavLink to="/about">About</NavLink>
            <NavLink to="/contact">Contact</NavLink>
            
        </div>
     );
}

export default Nav;
