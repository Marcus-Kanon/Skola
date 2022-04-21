import React from 'react';
import {useState, useEffect} from 'react';
import {removeTeamMember} from './TeamData.js';
import PokemonCard from './Search/PokemonCard.jsx';
import './Search/PokemonCard.css';

function Team({teamState, cachedDetailsState}) {

    console.log(teamState.team);

    return (
            <div>
                <h1>Team</h1>
                <div className='pokemon-card-container'>
                { teamState.team.map(member => (
                    <PokemonCard key={member.key} pokemon={member} cachedDetailsState={cachedDetailsState}>
                        <a onClick={() => {removeTeamMember(teamState, member);}}>Remove from team</a>
                    </PokemonCard>
                    ))}
                </div>
            </div>
     );
}

export default Team;