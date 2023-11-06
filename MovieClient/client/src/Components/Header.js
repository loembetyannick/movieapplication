import React from 'react'
import '../Styles/Header.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faVideo } from '@fortawesome/free-solid-svg-icons'

const Header = () => {
  return (
    <div className='header-container'>
      <div className='header-left'>
        <FontAwesomeIcon icon={faVideo} />
        <p>movie club</p>
      </div>
    </div>
  )
}

export default Header