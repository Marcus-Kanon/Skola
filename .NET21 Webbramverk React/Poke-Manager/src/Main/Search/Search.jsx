import React from 'react';
import {useState, useEffect} from 'react';
import {data, populatePokemonList} from './PokeDataFetcher.js';
import PokemonCard from './PokemonCard.jsx';
import "./PokemonCard.css";

function Search() {
    const [search, setSearch] = useState('');

    useEffect(() => {
        populatePokemonList();
    }, []);

    function handleChange(e) {
        setSearch(
            data.results
            .filter(pokemon => pokemon.name.toLowerCase().includes(e.target.value.toLowerCase()))
            .map(pokemon => {
                return(
                        <PokemonCard key={pokemon.url} pokemon={pokemon} />
                )
            }
            ));
    }

    return ( 
        <div>
            <h1>Search</h1>

            <input onChange={e => handleChange(e)} type="text" placeholder="Search..." />
            <div className="pokemon-card-container">
                Searching for: 
                {search}
            </div>
        </div>
        
     );
}

export default Search;