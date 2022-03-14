import React, { Component } from 'react';

export class Student extends Component {
 
  constructor(props) {
    super(props);
    var student_local = props.location.state;
    this.state = {
      student: student_local,
      address: {},
      classStudent: [],
      studentPlan: [],
      individualClass: [],
      teacher: {}
    };
    console.log("student", this.state.student);
  }

  componentDidMount() {

    // //get student address
    // fetch('https://localhost:44471/Students')
    //   .then(response => response.json())
    //   .then(data => {
    //     this.setState({ address: data });
    //     console.log("students", this.state.address);
    //   })

    // //get student address
    // fetch('http://localhost:3000/address/' + this.state.student.address_id)
    //   .then(response => response.json())
    //   .then(data => {
    //     this.setState({ address: data });
    //     console.log("address", this.state.address);
    //   })

    // //get student classes
    // fetch('http://localhost:3000/classStudent?student_id=' + this.state.student.id)
    //   .then(response => response.json())
    //   .then(data => {
    //     data.map((current_class) => (
    //       fetch('http://localhost:3000/class/' + current_class.class_id)
    //         .then(response => response.json())
    //         .then(data => {
    //           current_class.class = data;
    //         })
    //     ));
    //     this.setState({ classStudent: data });
    //     console.log("classStudent", this.state.classStudent);
    //   })

    // //get student paying plan
    // fetch('http://localhost:3000/studentPlan?student_id=' + this.state.student.id)
    //   .then(response => response.json())
    //   .then(data => {
    //     data.map((current_studentplan) => (
    //       //check plan is active and ok
    //       //if it is get the plan info
    //       fetch('http://localhost:3000/plan/' + current_studentplan.plan_id)
    //         .then(response => response.json())
    //         .then(data => {
    //           current_studentplan.plan = data;
    //         })
    //     ));
    //     this.setState({ studentPlan: data });
    //     console.log("studentPlan", this.state.studentPlan);
    //   })

    // //get student individual classes
    // fetch('http://localhost:3000/individualClass?student_id=' + this.state.student.id)
    //   .then(response => response.json())
    //   .then(data => {
    //     var local_data = data;
    //     local_data.map((current_individualClass) => (
    //       fetch('http://localhost:3000/teacher/' + current_individualClass.teacher_id)
    //         .then(response => response.json())
    //         .then(data => {
    //           current_individualClass.teacher = data;
    //         })
    //     ));
    //     this.setState({ individualClass: local_data });
    //     console.log("individualClass", this.state.individualClass);
    //   })

  }

  render() {
    return (
      <div className='row'>
        <div className='col-6'>
          <h3>Aluno</h3>
          <p><b>Nome:</b> {this.state.student.name}</p>
          <p><b>Género:</b> {this.state.student.gender === "m" ? "Masculino" : "Feminino"}</p>
          <p><b>Morada:</b> {this.state.student.address.street}, <br /> {this.state.student.address.street2}, {this.state.student.address.postalCode} - {this.state.student.address.city}</p>
        </div>
        <div className='col'>
          <h3>Apoio</h3>
          <p><b>Plano:</b> { this.state.student.plan.name } </p>
          <h4>Aula</h4>
          {this.state.classStudent.map((current_class, index) => {
            console.log(current_class);
            return (
            <p key={index} >
              <span><b>inicio:</b> {current_class.start_time} </span>
              <span><b>fim:</b> {current_class.end_time} </span>
            </p>
          );})}

        </div>
        <div className='col'>
          <h3>Explicações</h3>
          {this.state.student.individualClasses.map((indClass, index) => {
            console.log(indClass);
            var datee = new Date(indClass.startTime);
            console.log(datee.toLocaleDateString())
            return (
            <p key={index} >
              {indClass.teacher.name} - {indClass.date}<br />
              {indClass.starttimehour} - {indClass.endtimehour}
            </p>
            )
          })}
          <p>add +</p>
        </div>
      </div>
    );
  }
}
