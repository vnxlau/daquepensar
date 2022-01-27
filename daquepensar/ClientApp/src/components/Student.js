import React, { Component } from 'react';

export class Student extends Component {

  constructor(props) {
    super(props);
    var student_local = props.location.state;
    this.state = { student: student_local };
    console.log(this.state.student);
  }

  render() {
    return (
      <div>
        <h1>Aluno</h1>
        <p>{this.state.student.name}</p>
      </div>
    );
  }
}
