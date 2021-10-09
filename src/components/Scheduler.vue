<template>
  <div ref="scheduler"></div>
</template>
 
<script>
import 'dhtmlx-scheduler';
import axios from 'axios';
export default {
  name: 'scheduler',
  props: {
    events: {
      type: Array,
      default () {
        return {events: []}
      }
    }
  },
 methods: {
    $_initSchedulerEvents: function() {
      if (!scheduler.$_eventsInitialized) 
          
        scheduler.attachEvent("onEventAdded", (id, ev) => {
            this.$emit("event-updated", id, "inserted", ev);
            console.log("Inserted")
            console.log(ev.start_date)
            const event = {
              start_date : ev.start_date,
              end_date : ev.end_date,
              text : ev.text,
              id : ev.id
            }
            axios.post("http://localhost:8081/todo",event)
            .then(response => console.log(response))
        });
        scheduler.attachEvent("onEventChanged", (id, ev) => {
            this.$emit("event-updated", id, "updated", ev);
            console.log("Updated")
            console.log(ev)
            const event = {
              start_date : ev.start_date,
              end_date : ev.end_date,
              text : ev.text,
            }
            axios.put(`http://localhost:8081/todo/${ev.id}`,event)
            .then(response => console.log(response))
        });
        scheduler.attachEvent("onEventDeleted", (id, ev) => {
            this.$emit("event-updated", id, "deleted");
            console.log("Deleted")
            console.log(ev)
            const event = {
              start_date : ev.start_date,
              end_date : ev.end_date,
              text : ev.text,
            }
            axios.delete(`http://localhost:8081/todo/${ev.id}`,event)
            .then(response => console.log(response))
        });
        scheduler.$_eventsInitialized = true;
      }
    },
  mounted: function () {
    scheduler.skin = "material";
    scheduler.config.header = [
        "day",
        "week",
        "month",
        "date",
        "prev",
        "today",
        "next"
    ];
    this.$_initSchedulerEvents();
    scheduler.init(this.$refs.scheduler, new Date(2021, 8, 28), "week");
    scheduler.parse(this.$props.events);
  
  },
}
</script>
 
<style>
    @import "~dhtmlx-scheduler/codebase/dhtmlxscheduler_material.css";
</style>