import { useState } from 'react'
import logo from './logo.svg'
import './App.css'
import Lista from './Lista.jsx'

function App() {
  const [count, setCount] = useState(0)

  return (
    <div className="App">
      <Lista></Lista>
    </div>
  )
}

export default App
