import React from 'react';
import {useState, useEffect} from 'react';
import {data, populatePokemonList} from './Search/PokeDataFetcher.js';
import {team, removeTeamMember} from './TeamData.js';
import PokemonCard from './Search/PokemonCard.jsx';
import './Search/PokemonCard.css';

function Team() {

const [changer, setChanger] = useState(false);

    return (
            <div>
                <h1>Team</h1>
                <div className='pokemon-card-container'>
                { team.map(member => (
                    <PokemonCard key={member.key} pokemon={member}>
                        <a onClick={() => {removeTeamMember(member); setChanger(!changer)}}>Remove from team</a>
                    </PokemonCard>
                    ))}
                </div>
            </div>
     );
}

export default Team;