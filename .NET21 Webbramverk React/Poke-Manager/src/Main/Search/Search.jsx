import React from 'react';
import {useState, useEffect} from 'react';
import {populatePokemonList} from './PokeDataFetcher.js';
import {addTeamMember} from '../TeamData.js';
import PokemonCard from './PokemonCard.jsx';
import "./Search.css";
import "./PokemonCard.css";

function Search() {
    const [search, setSearch] = useState('');
    const [data, setData] = usestate([]);

    useEffect(() => {
        async function something() {
            let incoming = await populatePokemonList();
            setData(incoming);

        }
        something();
        // setSearch(data.results.map(pokemon => (
        //     <PokemonCard key={pokemon.url} pokemon={pokemon}>
        //         <a onClick={() => {addTeamMember(pokemon)}}>Add to team</a>
        //     </PokemonCard>
        // )));
    }, []);

    function handleChange(e) {
        setSearch(
            data.results
            .filter(pokemon => pokemon.name.toLowerCase().includes(e.target.value.toLowerCase()))
            .map(pokemon => {
                return(
                        <PokemonCard key={pokemon.url} pokemon={pokemon}>
                            <a onClick={() => {addTeamMember(pokemon)}}>Add to team</a>
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