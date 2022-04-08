import React from 'react';
import {NavLink} from 'react-router-dom'
import './Nav.css';

function Nav() {
    return ( 
        <div className='nav-container'>
            <div></div>
            <NavLink to="/Start">Start</NavLink>
            <NavLink to="/Search">Search Pokemon</NavLink>
            <NavLink to="/Team">My Team</NavLink>
            <div></div>
        </div>
     );
}

export default Nav;