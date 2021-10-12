
<template>
  <div class="container">
    <scheduler
      class="left-container"
      :events="events"
      @event-updated="logEventUpdate"
    ></scheduler>
    <div class="right-container">
      <ul class="scheduler-messages">
        <li
          class="scheduler-message"
          v-for="message in messages"
          :key="message"
        >
          {{ message }}
        </li>
      </ul>
    </div>
    <div :events="events" @event-updated="fetchdata">{{events}}</div>
  </div>
</template>
 
<script>
import Scheduler from "./components/Scheduler.vue";
import axios from "axios";


export default {
  name: "app",
  components: { Scheduler },
  data() {
    return {
      events: [],
      messages: [],
    };
  },
  mounted() {
    this.fetchdata();
},
methods: {

    async fetchdata(){
      let res = await axios.get('http://localhost:8081/todo');
      const data = res.data;
      data.forEach(event => {
        this.events.push(event)
      });
    },
    addMessage(message) {
      this.messages.unshift(message);
      if (this.messages.length > 40) {
        this.messages.pop();
      }
    },
    logEventUpdate(id, mode, ev) {
      let text = ev && ev.text ? ` (${ev.text})` : "";
      let message = `Event ${mode}: ${id} ${text}`;
      this.addMessage(message);
    },
  },
};
</script>

<style>
html,
body {
  height: 100%;
  margin: 0;
  padding: 0;
}
.container {
  height: 100%;
  width: 100%;
}
.left-container {
  overflow: hidden;
  position: relative;
  height: 100vh;
  display: inline-block;
  width: 75%;
}
.right-container {
  border-right: 1px solid #cecece;
  float: right;
  height: 100%;
  width: 20%;
  box-shadow: 0 0 5px 2px #aaa;
  position: relative;
  z-index: 2;
}
.scheduler-messages {
  list-style-type: none;
  height: 100%;
  margin: 0;
  overflow-x: hidden;
  overflow-y: auto;
  padding-left: 5px;
}
.scheduler-messages > .scheduler-message {
  background-color: #f4f4f4;
  box-shadow: inset 5px 0 #d69000;
  font-family: Geneva, Arial, Helvetica, sans-serif;
  font-size: 14px;
  margin: 5px 0;
  padding: 8px 0 8px 10px;
}
</style>