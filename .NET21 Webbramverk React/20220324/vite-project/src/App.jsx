import { useState } from 'react'
import logo from './logo.svg'
import './App.css'
import OnOffButton from './OnOffButton.jsx'
import Counter from './Counter.jsx'
import ProductDetails from './ProductDetails'
import Fancy from './Fancy'
import Orderly from './Orderly'
import Tabbie from './Tabbie'

function App() {


  return (
    <div> <h1>Min App-komponent</h1>
    <Counter></Counter>
    <OnOffButton></OnOffButton>
    <ProductDetails></ProductDetails>
    <Fancy color="#00FF00">tests</Fancy>
    <Orderly value="2"></Orderly>
    <Tabbie></Tabbie>
    </div>
  )
}

export default App
