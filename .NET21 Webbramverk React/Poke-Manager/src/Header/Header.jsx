import React from 'react';
import Nav from './Nav.jsx';
import Banner from './Banner.jsx';

function Header() {
    return ( 
        <header>
            <Banner />
            <Nav />
        </header>
     );
}

export default Header;