const addTeamMember = (teamState, member) => {
    if(teamState.team.length < 5) {
        console.log(member);
        teamState.set(team=>[...team, {...member, key: team.length}]);
    }
}

const removeTeamMember = (teamState, member) => {
    teamState.team.length > 0 ? teamState.set(p=>[...p.team.filter(pokemon => pokemon.key != member.key)]) : teamState.set(member);
}

export {addTeamMember, removeTeamMember};
