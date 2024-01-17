import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
  // const [count, setCount] = useState(0) 
  const[activities, setActivities] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/activities')
    .then (response => {
      setActivities(response.data)
    })
  }, [])

  return (
    <div>
    <Header as ='h2' icon= 'users' content='Reactivities'/>
    <List>   
      {activities.map((activity: any) => (
         <List.Item key = {activity.id}>
        {/* <li key = {activity.id}>  */}
          {activity.title}
          </List.Item>
        // </li>
      ))}
      </List>
    </div>
  )
}
export default App