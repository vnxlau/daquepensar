import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <div id='home_div'>
        <div>
          <h1>
            HOME
          </h1>
          <p>o teu centro de estudos online</p>
        </div>
        <div className='span6'>
          <p>proximos eventos:</p>
          <p>...</p>
        </div>
      </div>
    );
  }
}
