import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export class Students extends Component {

  constructor(props) {
    super(props);
    this.state = { students: []};
  }

  componentDidMount() {
    fetch('http://localhost:3000/students')
      .then(response => response.json())
      .then(data => {
        this.setState({ students: data });
        console.log(data);
      })
  }

  handleListClick = param => (e) => {
    console.log(param);

  }

  render() {
    return (
      <div>
        <h1>Students</h1>

        {this.state.students.map((student, index) => (
          <p key={index} onClick={this.handleListClick(student)}>
            <Link to={{ pathname:'/Student', state: student}}> {student.name} </Link>
          </p>
        ))}

      </div>
    );
  }
}


