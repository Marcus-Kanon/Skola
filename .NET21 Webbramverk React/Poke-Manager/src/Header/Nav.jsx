import React from 'react';
import {NavLink} from 'react-router-dom'
import './Nav.css';

function Nav() {
    return ( 
        <div className='nav-container'>
            <NavLink to="/Start">Start</NavLink>
            <NavLink to="/Search">Search Pokemon</NavLink>
            <NavLink to="/Team">My Team</NavLink>
        </div>
     );
}

export default Nav;