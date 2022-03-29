import React from 'react';
import './Tab.css';
function Tab(props) {

    

    return ( 
        <div className='tab'>
            {props.children}, {props.id}
            <a onClick={() => props.callback()}> Remove ME!</a>
        </div>
     );
}

export default Tab;