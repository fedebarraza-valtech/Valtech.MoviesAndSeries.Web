<template>
  <div class="NewsPage">
    <v-row align="center" justify="center">
      <v-col>
        <h1>{{ model.title.value }}</h1>
        <h2>{{ model.author.value }}</h2>
        <v-img width="500" class="ma-auto my-5 mx-auto" :src="model.image.value.url"></v-img>
        <div v-html="model.body.value"></div>
        <ContentArea :model="model.contentBody.expandedValue"></ContentArea>
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
