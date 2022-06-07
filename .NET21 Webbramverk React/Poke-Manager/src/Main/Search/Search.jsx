import React from 'react';
import {useState, useEffect} from 'react';
import {addTeamMember} from '../TeamData.js';
import PokemonCard from './PokemonCard.jsx';
import "./Search.css";
import "./PokemonCard.css";

function Search({dataState, teamState, cachedDetailsState}) {
    const [search, setSearch] = useState('');

    return ( 
        <div>
            <div className='input-container'>
                <input className='search-input' onClick={e => e.target.value} onChange={e => {setSearch(e.target.value);}} type="text" placeholder="Search..." />
            </div>
            
            <div className="pokemon-card-container"> 
            {
                dataState.data != null ? dataState.data.results
                .filter(pokemon => pokemon.name.toLowerCase().includes(search))
                .map(pokemon => {return (
                    <PokemonCard key={pokemon.url} pokemon={pokemon} cachedDetailsState={cachedDetailsState}>
                        <a onClick={() => {addTeamMember(teamState, pokemon)}}>Add to team</a>
                    </PokemonCard>
                    )}
                ) : <h2>Laddar...</h2>
            }
                
            </div>
        </div>
        
     );
}

export default Search;