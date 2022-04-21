import React from 'react';
import {useState, useEffect} from 'react';
import {populatePokemonList} from './PokeDataFetcher.js';
import {addTeamMember} from '../TeamData.js';
import PokemonCard from './PokemonCard.jsx';
import "./Search.css";
import "./PokemonCard.css";

function Search({dataState, teamState, cachedDetailsState}) {
    const [search, setSearch] = useState('');
    

    function handleChange(e) {
        setSearch(
            dataState.data.results
            .filter(pokemon => pokemon.name.toLowerCase().includes(e.target.value.toLowerCase()))
            .map(pokemon => {
                return(
                        <PokemonCard key={pokemon.url} pokemon={pokemon} cachedDetailsState={cachedDetailsState}>
                            <a onClick={() => {addTeamMember(teamState, pokemon)}}>Add to team</a>
                        </PokemonCard>
                )
            }
            ));
    }

    return ( 
        <div>
            <div className='input-container'>
                <input className='search-input' onChange={e => handleChange(e)} type="text" placeholder="Search..." />
            </div>
            
            <div className="pokemon-card-container"> 
                {search}
            </div>
        </div>
        
     );
}

export default Search;