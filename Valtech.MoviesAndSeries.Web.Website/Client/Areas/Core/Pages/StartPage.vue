<template>
  <div class="StartPage">
      <h1>{{model.title.value}}</h1>
  </div>
</template>

<script>

import { mapState } from 'vuex';

export default {
    props: ['model'],
    computed: mapState({
        url: state => state.epiDataModel.model.url
    })
};
</script>
