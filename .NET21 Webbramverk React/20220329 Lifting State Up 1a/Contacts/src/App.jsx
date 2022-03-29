import { useState } from 'react'
import logo from './logo.svg'
import './App.css'
import ContactContainer from './components/ContactContainer'

function App() {
  const [count, setCount] = useState(0)

  return (
    <div className="App">
      <ContactContainer />
    </div>
  )
}

export default App
