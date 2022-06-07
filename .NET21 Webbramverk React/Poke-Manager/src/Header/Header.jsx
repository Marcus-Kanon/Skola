import React from 'react';
import Nav from './Nav.jsx';
import Banner from './Banner.jsx';
import { Router } from 'react-router-dom';

function Header() {
    return ( 
        <header>
            <Banner />
            
                <Nav />
            
        </header>
     );
}

export default Header;