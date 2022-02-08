import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export class Students extends Component {

  constructor(props) {
    super(props);
    this.state = { students: [] };
  }

  componentDidMount() {
    fetch('http://localhost:3000/student')
      .then(response => response.json())
      .then(data => {
        this.setState({ students: data });
      })
  }

  async populateStudentsData() {
    const response = await fetch('students', {
    });
    console.log(response);
    const data = await response.json();
    this.setState({ studentsServer: data, loading: false });
  }

  render() {
    return (
      <div className='row'>
        <h1>Students</h1>
        <div className='col-6'>
          {this.state.students.map((student, index) => (
            <p key={index} >
              <Link to={{ pathname: '/Student', state: student }}> {student.name} </Link>
              <Link to={{ pathname: '/Student', state: student }}> Editar </Link>
              <Link to={{ pathname: '/Student', state: student }}> Apagar </Link>
            </p>
          ))}
        </div>
        <div className='col-6'>
          Adicionar
        </div>
      </div>
    );
  }
}


