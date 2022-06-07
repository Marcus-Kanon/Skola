import React from 'react';
import { useState } from 'react';
import Tab from './Tab.jsx'

function Tabbie() {
    const [activeTab, setActiveTab] = useState(0);
    const [tabs, setTabs] = useState([]);
    const [parent, setParent] = useState(this);

    function addTab(text) {
        let newTabs = [];
        Object.assign(newTabs, tabs);
        newTabs.push(<Tab key={tabs.length} id={tabs.length} callback={removeTab}>{text}</Tab>);
        setTabs(newTabs);
        setActiveTab(tabs.length-1);
    }

    function removeTab(tab) {
        let copyTabs = [];
        console.log("Length: " + tabs.length);
        tabs.forEach(element => {
            if(true) {
                copyTabs.push(element)
            }
        });
        setTabs(copyTabs);
                
    }

    function spawnTabs() {
        let elementsBuilder = "";
        for (let i = 0; i < tabs.length; i++) {
            const element = tabs[i];
            elementsBuilder += element;
        }
        return elementsBuilder;
    }

    return ( 
        <div>
            <a onClick={() => addTab("Hej!")}>Add tab!</a>
            <>
            {tabs}
            </>
        </div>

     );
}

export default Tabbie;