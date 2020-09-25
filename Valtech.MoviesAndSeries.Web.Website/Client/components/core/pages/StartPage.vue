<template>
  <div class="StartPage">
    <v-row align="center" justify="center">
      <v-col>
        <h1>{{ model.title.value }}</h1>
        <ContentArea :model="model.content.expandedValue"></ContentArea>
      </v-col>
    </v-row>
  </div>
</template>

<script>
import { mapState } from 'vuex';
import ContentArea from '@components/ContentArea.vue';

export default {
    props: ['model'],
    components: {
        ContentArea,
    },
    computed: mapState({
        url: (state) => state.epiDataModel.model.url,
    }),
};
</script>
