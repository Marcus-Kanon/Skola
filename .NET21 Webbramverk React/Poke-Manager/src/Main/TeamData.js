
const addTeamMember = (member) => {
    if(team.length < 5) {
        team.push({...member, key: team.length});
    }
}

const removeTeamMember = (member) => {
    team.splice(team.indexOf(member), 1);
}

export {team, addTeamMember, removeTeamMember};
